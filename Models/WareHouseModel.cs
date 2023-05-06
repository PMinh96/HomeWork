namespace Homework.Models
{
    public class WareHouseModel
    {
        #region Ctors

        public WareHouseModel()
        {
        }

        public WareHouseModel(int id)
        {
            Id = id;
        }

        public WareHouseModel(int id, string name) : this(id)
        {
            Name = name;
        }

        #endregion Ctors

        public int Id { get; set; }
        public string Name { get; set; }
    }
}