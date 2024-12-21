// Записать элементы матрицы построчно в одномерный массив и найти его минимальный элемент.

       int[,] matrix = { 
            { 1, 2, 3 }, 
            { 4, 5, 6 }, 
            { 7, 8, 9 } 
                        }; 
        
       int Stroka = matrix.GetLength(0); 
       int Stolb = matrix.GetLength(1); 
       
       int[] array = new int[Stroka * Stolb]; 
        
       int index = 0; 
            for (int i = 0; i < Stroka; i++) 
        { 
            for (int j = 0; j < Stolb; j++) 
            { 
                array[index++] = matrix[i, j]; 
            } 
        } 
       int min = array[0]; 
            for (int i = 1; i < array.Length; i++) 
        { 
            if (array[i] < min) 
            { 
                min = array[i]; 
            } 
        } 
          Console.WriteLine("Минимальный элемент: " + min); 
