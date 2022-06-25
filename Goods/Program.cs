using Goods;

Good[] goods =
{
    new HouseholdChemical(1, "Mr Proper", "средство для мытья полов", 20, 500, 1, new DateTime(2025, 1,1)),
    new HouseholdChemical(2, "Mr Proper", "средство для мытья стёкол", 30, 500, 1, new DateTime(2025, 1,1)),
};


ManageGoods.Sale(ref goods, new HouseholdChemical(5, "Mr Proper", "средство для мытья стёкол, апельсин", 31, 500, 1, new DateTime(2025, 1,1)));

foreach (var good in goods)
{
    good.PrintInfo();
}