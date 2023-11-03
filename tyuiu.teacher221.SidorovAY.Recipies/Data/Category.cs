namespace tyuiu.teacher221.SidorovAY.Recipies.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Recipe> Recipies { get; set; }
    }
}
