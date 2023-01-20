//Завдання 2

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 

//Потрібно: 

//Створити клас AbstractHandler. У тілі класу створити методи void Open(), void Create(), void Change(), void Save(). 
//    Створити похідні класи XMLHandler, TXTHandler, DOCHandler від базового класу AbstractHandler. 
//    Написати програму, яка виконуватиме визначення документа 
//    і для кожного формату мають бути методи відкриття, створення, редагування, збереження певного формату документа.

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XMLHandler handlerXML = new XMLHandler();
            handlerXML.Create();
            handlerXML.Open();
            handlerXML.Save();
            handlerXML.Change();

            TXTHandler handlerTXT = new TXTHandler();
            handlerTXT.Create();
            handlerTXT.Open();
            handlerTXT.Save();
            handlerTXT.Change();

            DOCHandler handlerDOCHandler = new DOCHandler();
            handlerDOCHandler.Create();
            handlerDOCHandler.Open();
            handlerDOCHandler.Save();
            handlerDOCHandler.Change();
        }
    }
}