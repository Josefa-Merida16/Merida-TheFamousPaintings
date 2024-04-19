using PaintingModel;
using PaintingDL;
using System.Reflection;
namespace PaintingBL
{
    public class BusinessLogic
    {

        public List<Model> GMS()
        {
            DataLayer dataServices = new DataLayer();
            return dataServices.GMS();

        }
    }
}