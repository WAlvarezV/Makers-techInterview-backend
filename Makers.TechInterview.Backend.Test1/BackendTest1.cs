namespace Makers.TechInterview.Backend.Test1
{
    /// <summary>
    /// The backend test1.
    /// </summary>
    public class BackendTest1
    {
        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            var list1 = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6
            };

            var list2 = new List<int>
            {
                2,
                3,
                4,
                5,
                6,
                7
            };
            var list3 = new List<int>
            {
                2,
                3,
                4,
                5,
                6,
                7
            };

            var listOfLists = new List<List<int>>()
            {
                list1,
                list2,
                list3,
            };
            var result = xyz(listOfLists);
        }


        /// <summary>
        /// Correción de nombres de función y variables para que sean más descriptivos, 
        /// uso de IEnumerables porque no se va a realizar tratamiento de datos en las listas solo lectura
        /// un posible bug es que siempre va a devolver cero si las listas contienen mas elementos de la cantidad de listas asociadas a la lista principal 
        /// adicional si por ejemplo tenemos tres listas y la tercer lista solo tiene dos elemsntos tendremos una excepción de rango excedido
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <returns>An int.</returns>


        public static int xyz(List<List<int>> arr) // funcion publica statica que recibe una lista de listas de enteros, retorna un entero
        {
            int sumP = 0; // declaración de varible tipo entero inicializada en cero
            int sumS = 0; // faltaba punto y coma al finalizar la línea -- declaración de varible tipo entero inicializada en cero
            for (int i = 0; i < arr.Count; i++) // ciclo for que itera de acuerdo a la cantidad de elementos de la lista principal, la lista de listas
                for (int j = 0; j < arr.Count; j++) // ciclo for anidado que itera de acuerdo a la cantidad de elementos de la lista principal, la lista de listas
                {
                    if (i == j) // condicional if se cumplira el número de veces que listas o elemetos tenga la lista principal
                    {
                        sumP += (arr[i][j]); // incremento de la variable sumP con el valor del primer elemento de la primer lista en su primer enntrada,
                                             // de ahi en adelante recorrera la siguiente lista en la siguiente posición, es decir primer vez, primera lista primera posición
                                             //segunda vez segunda lista segunda posición y así el número de listas que tenga lista pirncipal
                    }
                    if (((arr.Count - 1) - i) == j) // al restar -1 y el incremento del index i daran como resultado el mismo numero de iteraciones que la cantidad de elemento de la lista principal
                                                    // por lo cual el valor de sumP dara como resultado el mismo valor de sumS
                    {
                        sumS += (arr[i][j]); // incremento de la variable sumS con el valor del primer elemento de la primer lista en su primer enntrada,
                                             // de ahi en adelante recorrera la siguiente lista en la siguiente posición, es decir primer vez, primera lista primera posición
                                             //segunda vez segunda lista segunda posición y así el número de listas que tenga lista pirncipal
                    }
                }
            return Math.Abs(sumP - sumS); // Uso de la clse Math para obtener el valor absoluto de la diferencia de las dos suams que al quedar con el mismo valor, dara como resultado siempre 0
        }
    }
}
