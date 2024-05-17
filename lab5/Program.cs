namespace lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            try /// блок с кодом, который может вызвать исключение
            {
                Seller Vadim  = new Seller();
                Buyer Artem = new Buyer(14);

                Vadim.Sell("алкоголь", Artem);
            }
            catch (SaleException ex) /// перехватываем исключение
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) /// перехватываем все остальные исключения
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
