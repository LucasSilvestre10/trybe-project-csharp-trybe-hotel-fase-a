# Trybe Hotel - Fase A

Bem-vindo ao repositório do projeto Trybe Hotel, uma API desenvolvida para uma aplicação de reserva de hotéis em várias redes. Abaixo, detalhamos os requisitos implementados no projeto:

1. **Requisito 1 - Implemente as models da aplicação:**
   - Implementação das models City, Hotel e Room em `src/TrybeHotel/Models/`.
   - Cada model foi estruturada conforme especificado no diagrama de entidade-relacionamento, definindo propriedades e relações.

2. **Requisito 2 - Desenvolva o endpoint GET /city:**
   - Endpoint acessível via URL /city, tipo GET.
   - Método `GetCities()` implementado em `src/TrybeHotel/Controllers/CityController.cs`.
   - Lógica de interação com o banco de dados no método `GetCities()` em `src/TrybeHotel/Repository/CityRepository.cs`.
   - A resposta segue o formato esperado:
     ```json
     [
        {
    	    "cityId": 1,
    	    "name": "Rio Branco"
        },
        /*...*/
     ]
     ```

3. **Requisito 3 - Desenvolva o endpoint POST /city:**
   - Endpoint acessível via URL /city, tipo POST.
   - Método `PostCity()` implementado em `src/TrybeHotel/Controllers/CityController.cs`.
   - Lógica de interação com o banco de dados no método `AddCity()` em `src/TrybeHotel/Repository/CityRepository.cs`.
   - A resposta segue o formato esperado:
     ```json
     {
          "cityId": 2,
          "name": "Rio de Janeiro"
     }
     ```

4. **Requisito 4 - Desenvolva o endpoint GET /hotel:**
   - Endpoint acessível via URL /hotel, tipo GET.
   - Método `GetHotels()` implementado em `src/TrybeHotel/Controllers/HotelController.cs`.
   - Lógica de interação com o banco de dados no método `GetHotels()` em `src/TrybeHotel/Repository/HotelRepository.cs`.
   - A resposta segue o formato esperado:
     ```json
     [
        {
    	      "hotelId": 1,
    	      "name": "Trybe Hotel SP",
    	      "address": "Avenida Paulista, 1400",
    	na      "cityId": 1,
    	      "cityName": "São Paulo"
    	  },
        /*...*/
     ]
     ```

5. **Requisito 5 - Desenvolva o endpoint POST /hotel:**
   - Endpoint acessível via URL /hotel, tipo POST.
   - Método `PostHotel()` implementado em `src/TrybeHotel/Controllers/HotelController.cs`.
   - Lógica de interação com o banco de dados no método `AddHotel()` em `src/TrybeHotel/Repository/HotelRepository.cs`.
   - A resposta segue o formato esperado:
     ```json
     {
          "hotelId": 2,
          "name": "Trybe Hotel RJ",
          "address": "Avenida Atlântica, 1400",
          "cityId": 2,
          "cityName": "Rio de Janeiro"
     }
     ```

6. **Requisito 6 - Desenvolva o endpoint GET /room/:hotelId:**
   - Endpoint acessível via URL /room/:hotelId, tipo GET.
   - Método `GetRoom()` implementado em `src/TrybeHotel/Controllers/RoomController.cs`.
   - Lógica de interação com o banco de dados no método `GetRooms()` em `src/TrybeHotel/Repository/RoomRepository.cs`.
   - A resposta segue o formato esperado:
     ```json
     [
        {
    	      "roomId": 1,
    	      "name": "Suite básica",
    	      "capacity": 2,
    	      "image": "image suite",
    	      "hotel": {
  			        "hotelId": 1,
  			        "name": "Trybe Hotel SP",
  			        "address": "Avenida Paulista, 1400",
  			        "cityId": 1,
  			        "cityName": "São Paulo"
    	      }
    	  },
        /*...*/
     ]
     ```

7. **Requisito 7 - Desenvolva o endpoint POST /room:**
   - Endpoint acessível via URL /room, tipo POST.
   - Método `PostRoom()` implementado em `src/TrybeHotel/Controllers/RoomController.cs`.
   - Lógica de interação com o banco de dados no método `AddRoom()` em `src/TrybeHotel/Repository/RoomRepository.cs`.
   - A resposta segue o formato esperado:
     ```json
     {
          "roomId": 1,
          "name": "Suite básica",
          "capacity": 2,
          "image": "image suite",
          "hotel": {
              "hotelId": 1,


              "name": "Trybe Hotel SP",
              "address": "Avenida Paulista, 1400",
              "cityId": 1,
              "cityName": "São Paulo"
          }
     }
     ```

8. **Requisito 8 - Desenvolva o endpoint DELETE /room/:roomId:**
   - Endpoint acessível via URL /room/:roomId, tipo DELETE.
   - Método `Delete()` implementado em `src/TrybeHotel/Controllers/RoomController.cs`.
   - Lógica de interação com o banco de dados no método `DeleteRoom()` em `src/TrybeHotel/Repository/RoomRepository.cs`.
   - A resposta é o status 204.

9. **Requisito 9 - Desenvolva testes que cubram no mínimo 40% de linhas:**
   - Testes de integração implementados no arquivo `src/TrybeHotel.Test/IntegrationTest.cs`.
   - Os testes cobrem no mínimo 40% das linhas de código.

**Habilidades Técnicas Utilizadas:**
- **Linguagem:** C#
- **Framework:** ASP.NET
- **Banco de Dados:** Entity Framework
- **Testes:** xUnit, Moq
- **Controle de Versão:** Git
