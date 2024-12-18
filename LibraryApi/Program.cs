using LibraryApi.Classes;
using LibraryApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//Menu menu = new Menu();
//bool keepGoing = true;

//while (keepGoing)
//{
//    menu.ExibMenu();
//    string choice = Console.ReadLine();

//    switch (choice)
//    {
//        case "1":
//            //AddReaded();
//            break;
//        case "2":
//            //AddWantToRead();
//            break;
//        case "3":
//            //ListReaded();
//            break;
//        case "4":
//            //ListWantToRead();
//            break;
//        case "5":
//            //DeleteReaded();
//            break;
//        case "6":
//            //DeleteWantToRead();
//            break;
//        case "7":
//            //UpdateReaded();
//            break;
//        case "8":
//            //UpdateWantToRead();
//            break;
//        case "9":
//            var bookController = new BookController();
//            bookController.GetBookById(id);
//            break;
//        case "11":
//            keepGoing = false;
//            break;
//        default:
//            Console.WriteLine("Opção inválida. Tente novamente.");
//            Console.ReadLine();
//            break;
//    }
//}

