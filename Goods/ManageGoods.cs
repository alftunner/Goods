namespace Goods;

public class ManageGoods
{
    public static void Income(ref Good[] goods, Good good)
    {
        bool flag = false;
        for (int i = 0; i < goods.Length; i++)
        {
            if (goods[i].Id == good.Id)
            {
                goods[i].Quantity += good.Quantity;
                flag = true;
            }
        }

        if (!flag)
        {
            Array.Resize(ref goods, goods.Length + 1);
            goods[^1] = good;
        }
        Console.WriteLine("Товар поставлен на приход");
    }
    
    public static void Sale(ref Good[] goods, Good good)
    {
        bool flag = false;
        for (int i = 0; i < goods.Length; i++)
        {
            if (goods[i].Id == good.Id)
            {
                if ((goods[i].Quantity - good.Quantity) >= 0)
                {
                    goods[i].Quantity -= good.Quantity;
                    goods[i].checkQuantity();
                    Console.WriteLine($"Товар успешно продан");
                }
                else
                {
                    Console.WriteLine($"Для покупки доступно только {goods[i].Quantity}");
                }
                flag = true;
            }
        }

        if (!flag)
        {
            Console.WriteLine($"Такого товара на складе нет!");
        }
    }
}