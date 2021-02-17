# Shopping Cart

Funciones utilizadas para simular un carrito de compras.

### Pre-requisitos 📋

Visual Studio
Visual Studio Code
Conexión a internet

### Ejecución 🔧

Para ejecutar las pruebas solo colocandonos dentro del directorio del proyecto ejecutamos en la terminal
el comando dotnet test. Las pruebas solo prueban un HappyCase, en caso de necesitar que se realicen
validaciones de datos favor de comentarlo.

Todos los test están incluidos en la solución/archivo Testing/Test.cs

En el caso de que se requiera hacer pruebas manuales se puede descomentar el archivo Program.cs
y sobre el método Main comenzar a realizar llamadas a las funciones.

#### Ejemplificar la llamada al Objeto ShoppingCart 🔧
Al momento de llamar a la clase Tools entonces se inicializa el Objeto ShoppingCart el cual genera un objeto vacío 
y listo para que se añadan valores como lo hace un Carrito de compras real.

Cuando se ejecuta la función AddItem entonces se añaden nuevos artículos al carrito siempre y cuando no exista
actualmente en el carrito, en caso de existir se aumenta la cantidad de los artículos en el mismo.

Al ejecutar la funcion GetTotalItems se obtiene un total de items diferentes en el carrito.

Al ejecutar la función GetTotalCartPrice se obtiene el precio total a pagar por los productos añadidos.

Para finalizar cuando se llama a la función Buy y se manda como parámetro la cantidad a pagar entonces se verifica
que no sea mayor al precio total a pagar y se aplica el pago, en caso de ser mayor se regresa un mensaje indicandolo.


