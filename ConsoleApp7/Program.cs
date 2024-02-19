//class Person
//{
//    public string Name { get; set; } = "";
    
//}

//class Program
//{
//    public static void Main()
//    {
//        Person person = new Person();
//        person.Name = "Test";
//        Person person2 = new Person();
//        Console.WriteLine(person.GetType().Name);

//     if(person.GetType().Equals(person2.GetType()))
//        {

//            Console.WriteLine("equals");
//        }
//        if (person is Person )
//        {

//            Console.WriteLine("equals");
//        }

//        Console.WriteLine(person.GetHashCode());
//        Console.WriteLine(person.Name.GetHashCode());
//        Console.WriteLine(person2.GetHashCode());

//        Console.WriteLine(person.Name.ToString());
//        Console.WriteLine(person.Name);
//    }
//}

//class Person<T>
//{
//    public T Id { get; set; }
//    public string Name { get; set; }
//    public Person(T id, string name)
//    {
//        Id = id;
//        Name = name;
//    }
//}

class Program
{
    public static void Main()
    {
        Messenger<Message> telegram = new Messenger<Message>();
        telegram.SendMessage(new Message("Hello World"));
    }
}


class Messenger<T> where T : Message
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
}

class Message
{
    public string Text { get; } // текст сообщения
    public Message(string text)
    {
        Text = text;
    }
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}