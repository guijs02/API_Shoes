Web API criada a fim de obter todos os tenis através de uma base de dados, sendo buscada por modelo ou marca.

Endpoints da API:
<br>
GET: Shoes/{modelo}/GetModelo -> obter pelo nome do modelo
```json
[
  {
    "id": 4,
    "marca": "Nike",
    "modelo": "Zoom Fly"
  },
  {
    "id": 23,
    "marca": "Nike",
    "modelo": "Zoom Fly"
  }
]
```

<br>
GET: Shoes/{marca}/GetMarca -> obter pelo nome da marca

```json
[
  {
    "id": 46,
    "marca": "adidas",
    "modelo": "converse"
  }
]
```
<br>

GET: Shoes/ -> obter todos os tenis

```json
{
    "id": 1,
    "marca": "Nike",
    "modelo": "Jordan 8"
  },
  {
    "id": 2,
    "marca": "Nike",
    "modelo": "LeBron 7"
  },

```

