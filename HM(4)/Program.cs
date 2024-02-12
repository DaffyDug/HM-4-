using System;
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books(200, 2021, AUTHOR.The_Brothers_Grimm, "da", BINDING_TYPE.Soft);
            Books books1 = new Books(122, 1999, AUTHOR.William_Shakespeare, "podumai", BINDING_TYPE.Solid);
            Books books2 = new Books(192, 2019, AUTHOR.Leo_Tolstoy, "inache", BINDING_TYPE.Solid);
            Books books3 = new Books(120, 1150, AUTHOR.Victor_Hugo, "goroda", BINDING_TYPE.Soft);
            List<Books> books4 = new List<Books>() { books, books1, books2, books3 };
            Librery librery = new Librery(books4);
        }
    }
}
//Описать класс книги, у которой должны быть следующие поля:
//1 – Кол - во страниц в книге.
//2 – Год выхода
//3 – Автор 
//4 – Название 
//5 – Тип переплёта
//Для ВСЕХ полей в классе книги реализовать публичный метод ИЛИ свойство GET (На ваш выбор).
//Метод или свойство SET должны остаться закрытыми.
class Books
{
    public int _pages { get; private set; }
    public int _released { get; private set; }
    public AUTHOR _author { get; private set; }
    public string _title { get; private set; }
    public BINDING_TYPE _binding_type { get; private set; }
    public Books(int pages, int released, AUTHOR author, string title, BINDING_TYPE binding_type)
    {
        _pages = pages;
        _released = released;
        _author = author;
        _title = title;
        _binding_type = binding_type;
    }
}
//Создать класс библиотеки и добавить в него поле с коллекцией книг.
//В классе библиотеке реализовать методы по работе с коллекцией книг такие как:
//1 – Получение ВСЕХ книг по Автору.
//2 – Получение ВСЕХ книг по переплёту.
//3 – Добавление новой книги.
//4 – Удаление книги.
class Librery
{
    private List<Books> _books;

    public Librery(List<Books> books)
    {
        _books = books;
    }
    public List<Books> GetBoocksAuthor(AUTHOR author)
    {
        List<Books> result = new List<Books>();
        foreach (var item in _books)
        {
            if (item._author == author)
            {
                result.Add(item);
            }
        }
        return result;
    }
    public List<Books> GetBoocks_BINDING_TYPE(BINDING_TYPE BigingType)
    {
        List<Books> result = new List<Books>();
        foreach (var item in _books)
        {
            if (item._binding_type == BigingType)
            {
                result.Add(item);
            }
        }
        return result;
    }
    public void RemoveBooks(Books books)
    {
        _books.Remove(books);
    }
    public void AddBooks(Books books)
    {
        _books.Add(books);
    }
}
//Поля «Автор» и «Тип переплёта» должны быть enum, в enum «Тип переплёта» необходимо поместить следующие значения (Мягкий, Твёрдый).
//В enum «Автор» нужно поместить 5 авторов по Вашему выбору.

public enum AUTHOR
{
    //Братья Гримм, Уильям Шекспир, Лев Толстой, Чарльз Диккенс, Виктор Гюго. главное не запутайтесь :)
    The_Brothers_Grimm,
    William_Shakespeare,
    Leo_Tolstoy,
    Charles_Dickens,
    Victor_Hugo
}
public enum BINDING_TYPE
{
    Soft,
    Solid
}