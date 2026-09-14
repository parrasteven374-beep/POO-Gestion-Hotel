# Sistema de Gestión de Reservas Hoteleras - POO en C# 🏨🛎️

Aplicación de consola en C# que simula la operación principal de un hotel: administración de clientes, empleados, asignación de habitaciones, consumo de servicios adicionales y procesamiento de pagos.

## 📋 Descripción del Sistema
El proyecto modela el flujo completo de una reserva hotelera mediante el paradigma de Programación Orientada a Objetos (POO), integrando múltiples entidades para gestionar la estancia y los cobros de un cliente.

## 🏗️ Estructura de Clases
- **`Cliente` y `Empleado`:** Representan a las personas involucradas en la transacción y atención.
- **`Habitacion`:** Define las características del hospedaje (tipo y tarifa por noche).
- **`ServicioComplementario` y `Consumo`:** Permiten agregar cargos adicionales como restaurante, spa, entre otros.
- **`Reserva`:** Agrupa las fechas de estancia, cliente, habitación assigned y lista de consumos.
- **`CobroGenerado`:** Encargado de calcular los costos totales del hospedaje más consumos adicionales y procesar el pago.

## ⚙️ Flujo del Programa
1. Registro del cliente y asignación del empleado responsable.
2. Creación de la reserva definiendo fechas de ingreso/salida y tipo de habitación.
3. Registro de consumos extras en la estancia (desayunos, spa, etc.).
4. Cálculo automatizado del total a pagar.
5. Procesamiento del cobro y estado final de la reserva.

## 🛠️ Tecnologías Utilizadas
- **Lenguaje:** C# (.NET)
- **Tipo de aplicación:** Consola
- **Paradigma:** Programación Orientada a Objetos (POO)
