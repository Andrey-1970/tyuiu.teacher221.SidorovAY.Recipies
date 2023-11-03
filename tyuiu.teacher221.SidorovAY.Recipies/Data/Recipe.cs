namespace tyuiu.teacher221.SidorovAY.Recipies.Data
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }  
        public IList<Ingridient> Ingridients { get; set;}
    }
}
