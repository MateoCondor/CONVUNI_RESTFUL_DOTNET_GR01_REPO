import { Platform } from 'react-native';

export type ConversionCategory = 'length' | 'mass' | 'temperature';

export type LoginResponse = {
  isAuth: boolean;
  message: string;
};

export type ConversionResponse = {
  result: number;
  message: string;
};

export type LengthRequest = {
  from: number;
  to: number;
  value: number;
};

export type MassRequest = {
  from: number;
  to: number;
  value: number;
};

export type TemperatureRequest = {
  from: number;
  to: number;
  value: number;
};
const unitEnumValues: Record<ConversionCategory, Record<string, number>> = {
  length: {
    mm: 0,
    cm: 1,
    m: 2,
    km: 3,
    ft: 4,
    in: 5,
    yd: 6,
    mi: 7,
  },
  mass: {
    mg: 0,
    g: 1,
    kg: 2,
    lb: 3,
    oz: 4,
    t: 5,
  },
  temperature: {
    c: 0,
    f: 1,
    k: 2,
    r: 3,
    re: 4,
  },
};

const defaultBaseUrl = Platform.select({
  android: 'http://192.168.100.158:5259',
  default: 'http://localhost:5259',
}) as string;

const envBaseUrl = process.env.EXPO_PUBLIC_API_BASE_URL?.trim();
const rawBaseUrl = envBaseUrl && envBaseUrl.length > 0 ? envBaseUrl : defaultBaseUrl;

export const API_BASE_URL = rawBaseUrl.endsWith('/') ? rawBaseUrl.slice(0, -1) : rawBaseUrl;

let authenticatedSession = false;

async function postJson<T>(path: string, body: Record<string, unknown>): Promise<T> {
  const response = await fetch(`${API_BASE_URL}${path}`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
      Accept: 'application/json',
    },
    body: JSON.stringify(body),
  });

  const json = (await response.json()) as T;

  if (!response.ok) {
    throw new Error((json as { message?: string }).message ?? 'Request failed');
  }

  return json;
}

export function login(username: string, password: string) {
  return postJson<LoginResponse>('/api/Auth/Login', { username, password });
}

export function convert(category: ConversionCategory, value: number, fromUnit: string, toUnit: string) {
  const capitalizedCategory = category.charAt(0).toUpperCase() + category.slice(1);
  const fromKey = fromUnit.trim().toLowerCase();
  const toKey = toUnit.trim().toLowerCase();
  const fromValue = unitEnumValues[category][fromKey];
  const toValue = unitEnumValues[category][toKey];

  if (fromValue === undefined || toValue === undefined) {
    throw new Error('Unidad no soportada para la conversion.');
  }

  return postJson<ConversionResponse>(`/api/UnitConversion/${capitalizedCategory}`, {
    value,
    from: fromValue,
    to: toValue,
  });
}

export function setSessionAuthenticated(value: boolean) {
  authenticatedSession = value;
}

export function isSessionAuthenticated() {
  return authenticatedSession;
}

export function clearSession() {
  authenticatedSession = false;
}
