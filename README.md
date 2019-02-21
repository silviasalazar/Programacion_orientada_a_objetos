# Programacion_orientada_a_objetos
#Tarea 1
## Programa que realiza operaciones básicas con fracciones

Este programa tiene la función de resolver funciones básicas utilizando fracciones, dentro de estas operaciones se encuentra la suma, resta, multiplicación y división.

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
        
        
         

         ###Conclusión
         Este trabajo es una tarea realizada para la clase de programación orientada a objetos con la finalidad de aprender a utilizar            adecuadamente cada uno de los procedimientos llevados a cabo en este programa. 
         


