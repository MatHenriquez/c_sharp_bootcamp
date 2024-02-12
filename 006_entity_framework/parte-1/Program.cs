using Cf.Dotnet.EntityFramework.Parte1;
using Cf.Dotnet.EntityFramework.Parte1.Models;
using Microsoft.EntityFrameworkCore;

// Creaci�n de un logger para registrar la actividad del programa.
var logger = LoggerFactory
    .Create(builder => builder.AddConsole().SetMinimumLevel(LogLevel.Debug))
    .CreateLogger<Program>();

// Nombre constante para la base de datos en memoria.
const string databaseName = "MyDB1";

// Creaci�n de un nuevo cliente al contexto.
var customer = new Customer
{
    Name = "Miguel"
};

logger.LogDebug("Customer {CustomerId} created", customer.Id);

// Creaci�n de una lista de art�culos del cat�logo.
var catalogItems = new List<CatalogItem>
{
    new()
    {
        Name = "Item 1",
        Price = 10
    },
    new()
    {
        Name = "Item 2",
        Price = 20
    }
};

logger.LogDebug("Catalog items {CatalogItems} created", catalogItems.Select(x => x.Id));

// Creaci�n de una orden.
var order = new Order
{
    CustomerId = customer.Id,
    CatalogItemId = catalogItems[0].Id,
    Quantity = 1
};

logger.LogDebug("Order {OrderId} created", order.Id);