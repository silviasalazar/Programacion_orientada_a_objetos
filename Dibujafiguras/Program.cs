using System;
using System.Collections.Generic;

namespace Dibujafiguras
{
class Vector2D
    {
        public int x, y;
        public Vector2D(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", x, y);
        }
    }
    class Color
    
    {
        public int r,g,b;
        public Color(int r,int g, int b)
        {
            this.r=r;
            this.g=g;
            this.b=b;
        }
        public override string ToString()
        {
            return String.Format("{2}",r,g,b);
        }
    }
    abstract class Figura
    {
        public Vector2D position;
        public string fill ,border;
        public Figura():this( new Vector2D(100, 100))
        {
        
        }
        public Figura(Vector2D pos)
        {
            position= pos;
            fill="White" ;
            border= "black";
        }

        public abstract void Dibuja();
    }

    class Circulo : Figura
    {
        private int radio;
        public Circulo(Vector2D pos, int radio):base(pos)
        {
         this.radio= radio;
        }
        public Circulo ():base()
        {
         this.radio= 10;
        }

        public override void Dibuja() 
        {
         Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, fill);
        }
    }
 
    class Rectangulo : Figura
    {
     
        public Rectangulo(Vector2D pos):base(pos)
        {
         
        }
        public Rectangulo ():base()
        {
        
        }

        public override void Dibuja() 
        {
         Console.WriteLine("Se dibuja un rectangulo en {0} de color {1}", position, fill);
        }
    }

     class Cuadrado : Figura
    {
     
        public Cuadrado(Vector2D pos):base(pos)
        {
         
        }
        public Cuadrado ():base()
        {
        
        }

        public override void Dibuja() 
        {
         Console.WriteLine("Se dibuja un cuadrado en {0} de color {1}", position, fill);
        }
    }

     class Triangulo : Figura
    {
     
        public Triangulo(Vector2D pos):base(pos)
        {
         
        }
        public Triangulo ():base()
        {
        
        }

        public override void Dibuja() 
        {
         Console.WriteLine("Se dibuja un triángulo en {0} de color {1}", position, fill);
        }
    }

     class Rombo : Figura
    {
     
        public Rombo(Vector2D pos):base(pos)
        {
         
        }
        public Rombo ():base()
        {
        
        }

        public override void Dibuja() 
        {
         Console.WriteLine("Se dibuja un rombo en {0} de color {1}", position, fill);
        }
    }


     class Elipse : Figura
    {
     
        public Elipse(Vector2D pos):base(pos)
        {
         
        }
        public Elipse ():base()
        {
        
        }

        public override void Dibuja() 
        {
         Console.WriteLine("Se dibuja un elipse en {0} de color {1}", position, fill);
        }
    }

     class Pentagono : Figura
    {
     
        public Pentagono(Vector2D pos):base(pos)
        {
         
        }
        public Pentagono ():base()
        {
        
        }

        public override void Dibuja() 
        {
         Console.WriteLine("Se dibuja un pentágono en {0} de color {1}", position, fill);
        }
    }


     class Hexagono : Figura
    {
     
        public Hexagono(Vector2D pos):base(pos)
        {
         
        }
        public Hexagono ():base()
        {
        
        }

        public override void Dibuja() 
        {
         Console.WriteLine("Se dibuja un hexágono en {0} de color {1}", position, fill);
        }
    }
    class Heptagono:Figura
    {
        public Heptagono(Vector2D pos):base(pos)
        {

        }
        public Heptagono():base()
        {

        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un heptágono en {0} de color {1}", position,fill);
        }
    }
    class Trapecio:Figura
    {
        public Trapecio(Vector2D pos):base(pos)
        {

        }
        public Trapecio():base()
        {

        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un trapecio en {0} de color {1}",position,fill);
        }
    }
    class Romboide:Figura
    {
        public Romboide(Vector2D pos):base(pos)
        {

        }
        public Romboide():base()
        {

        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un romboide en {0} de color {1}", position, fill);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras    = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2D(200,200)));
            figuras.Add(new Cuadrado(new Vector2D(300,300)));
            figuras.Add(new Triangulo(new Vector2D(400, 400)));
            figuras.Add(new Rombo(new Vector2D(500,500)));
            figuras.Add(new Elipse(new Vector2D(600,600)));
            figuras.Add(new Pentagono(new Vector2D(700,700)));
            figuras.Add(new Hexagono(new Vector2D(800,800)));
            figuras.Add(new Heptagono(new Vector2D(900,900)));
            figuras.Add(new Trapecio(new Vector2D(1000,1000)));
            figuras.Add(new Romboide(new Vector2D(1100,1100)));

            foreach(Figura f in figuras)
             f.Dibuja();        
        }
    }
}
