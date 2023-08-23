using fatorial;

 
Fatorial fatorial = new Fatorial(); 

for (int num = 1; num <= 10; num++)
        {
            int resultado = fatorial.CalculoFatorial(num); 
            Console.WriteLine($"O fatorial de {num} é {resultado}");
        }

