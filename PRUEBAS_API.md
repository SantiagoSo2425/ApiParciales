# Pruebas de APIs (Postman)

Base URL: `http://localhost:{puerto}/api`

Usar en todos los casos:
- Método: `POST`
- Header: `Content-Type: application/json`
- Body: `raw` -> `JSON`

## 1) sTrabajador
URL: `{{baseUrl}}/sTrabajador`

Body ejemplo:
```json
{
  "Nombres": "Juan Pérez",
  "HorasTrab": 48,
  "vrHora": 12000
}
```

## 2) sSerPub
URL: `{{baseUrl}}/sSerPub`

Body ejemplo:
```json
{
  "Estrato": 3,
  "Kkw": 120,
  "kM3": 30,
  "klTel": 50,
  "vtDolar": 4000
}
```

## 3) sJornal
URL: `{{baseUrl}}/sJornal`

Body ejemplo:
```json
{
  "vrHora": 10000,
  "hrDiurnas": 5,
  "hrNocturnas": 3,
  "domFestivo": false
}
```

## 4) sUniversidad
URL: `{{baseUrl}}/sUniversidad`

Body ejemplo:
```json
{
  "Promedio": 4.6,
  "EsPregrado": true
}
```

## 5) sAlmacen
URL: `{{baseUrl}}/sAlmacen`

Body ejemplo:
```json
{
  "vrCompra": 200000,
  "colorBolita": "azul"
}
```

## 6) sCliente
URL: `{{baseUrl}}/sCliente`

Body ejemplo:
```json
{
  "vrMontoAnual": 2000000,
  "tipoCliente": "preferente"
}
```

## Nota rápida
Si no sabes el puerto, ejecuta el proyecto y toma el de IIS Express (ejemplo: `http://localhost:12345`).
