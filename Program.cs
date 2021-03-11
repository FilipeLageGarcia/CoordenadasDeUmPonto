using System; 

class URI {

    static void Main(string[] args) { 

          string[] valores = Console.ReadLine().Split();

          double coodernadaX = double.Parse(valores[0]);
          double coodernadaY = double.Parse(valores[1]);

          if ( (coodernadaX > 0)&&(coodernadaY > 0))
          {
              Console.WriteLine("Q1");
          }
          else if ( (coodernadaX > 0)&&(coodernadaY < 0))
          {
              Console.WriteLine("Q4");
          }
          else if ( (coodernadaX < 0)&&(coodernadaY < 0))
          {
              Console.WriteLine("Q3");
          }
          else if ( (coodernadaX < 0)&&(coodernadaY > 0))
          {
              Console.WriteLine("Q2");
          }
          else if ( (coodernadaX == 0)&&!(coodernadaY == 0))
          {
              Console.WriteLine("Eixo Y");
          }
          else if ( !(coodernadaX == 0)&&(coodernadaY == 0))
          {
              Console.WriteLine("Eixo X");
          }
          else if ( (coodernadaX == 0)&&(coodernadaY == 0))
          {
              Console.WriteLine("Origem");
          }
 
    }

}