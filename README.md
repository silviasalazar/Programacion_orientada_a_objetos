# Programacion_orientada_a_objetos
# Tarea 1
## Programa que realiza operaciones básicas con fracciones
***Introducción***
Este programa tiene la función de resolver funciones básicas utilizando fracciones, dentro de estas operaciones se encuentra la suma, resta, multiplicación y división.

 Este trabajo es una tarea realizada para la clase de programación orientada a objetos con la finalidad de aprender a utilizar            adecuadamente cada uno de los procedimientos llevados a cabo en este programa. 

**¿Cómo funciona?**
El programa fue realizado utilizando programación por consola, utilizando atributos y métodos (en especial métodos constructores por su gran facilidad).

A continuación se mostrará el método utilizado para el código de cada una de las operaciones:

```
         1.SUMA
         public static Frac operator +(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.den + x.den * y.num, x.den * y.den);
            return result;
        }
        2.RESTA
        public static Frac operator -(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.den - x.den * y.num, x.den * y.den);
            return result;
        }
        3.MULTIPLICACIÓN
        public static Frac operator *(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.num , x.den * y.den);
            return result;
        }
        4.DIVISIÓN
        public static Frac operator /(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.den , x.den * y.num);
            return result;
        }```
        

        **Objetivo**
        
        Su objetivo es poder realizar las operaciones básicas fraccionarias de una manera mas rápida, eficiente y que sea correcta.
        
        A continuación podrás observar el código completo:
        
        
```
{
    class Frac
    {
        private int num;
        private int den;

        public Frac(int num, int den)
        {
            this.num = num;
            this.den = den;
        }
        public Frac()
        {
            num = 1;
            den = 1;
        }
        //SUMA
        public static Frac operator +(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.den + x.den * y.num, x.den * y.den);
            return result;
        }
        //RESTA
        public static Frac operator -(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.den - x.den * y.num, x.den * y.den);
            return result;
        }
        //MULTIPLICACIÓN
        public static Frac operator *(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.num , x.den * y.den);
            return result;
        }
        //DIVISIÓN
        public static Frac operator /(Frac x, Frac y)
        {
            Frac result = new Frac(x.num * y.den , x.den * y.num);
            return result;
        }
        //IMPRIMIR
        public void imprime()
        {
            Console.WriteLine("{0}/{1}", num, den);
        }

        public decimal a_decimal()
        {
            return num / den;
        }
    }
    class Program
    {
        static void Main()
        {
            Frac a = new Frac(1,5);
            Frac b = new Frac();
            Frac c = a+b;
            Frac d = a - b;
            Frac e = a * b;
            Frac f = a / b;

            //IMPRIMIR DATOS
            a.imprime();
            b.imprime();
            c.imprime();
            d.imprime();
            e.imprime();
            f.imprime();

            Console.ReadKey();
        }

    }
}
    ```


        
        
