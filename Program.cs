using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CinemaAdviser
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Здравствуйте, дорогой друг. Это программа поможет подобрать вам фильм для вечернего просмотра");
      Console.WriteLine("Как вас зовут?");
      string name = Console.ReadLine(); 

      Console.WriteLine("Здравствуйте, " + name);

      Console.WriteLine("Фильм какого жанры вы хотели бы посмотреть: комедия, драмма, фантастика, эротика?");
      string genre = Console.ReadLine();

      Console.WriteLine("В таком случае, рекомендую  посмотреть вам следующие фильмы:");
      if (genre == "комедия")
      {
        Console.WriteLine("* Иван Васильевич меняет профессию");
        Console.WriteLine("* Операцыя \"Ы\" и другие приключения Шурика");
        Console.WriteLine("* Назад в будущее");
        Console.WriteLine("* В джазе только девушки");
      }
      else if (genre == "фантастика")
      {
        Console.WriteLine("* Люди Икс");
        Console.WriteLine("* Черепашки ниндзя");
      }
      else if (genre == "эротика")
      {
        Console.WriteLine("Сколько вам лет?");
        string yearsString = Console.ReadLine();
        int years = Int32.Parse(yearsString);

        if (years < 18)
        {
          Console.WriteLine("К сожалению этот жанр доступен только для 18+");
          Console.WriteLine("Приходите через " + (18 - years) + " лет");
        }
        else
        {
          Console.WriteLine("* Эмануэль");
          Console.WriteLine("* Нимфоманка");
        }
      }
      else
      {
        Console.WriteLine("* Зеленая миля");
        Console.WriteLine("* Побег из Шоушенка");
      }

      Console.ReadLine();
    }
  }
}
