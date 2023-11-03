namespace tyuiu.teacher221.SidorovAY.Recipies.Data
{
    public class MesureType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Ingridient> Ingridients { get; set;}
    }
}
