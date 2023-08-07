using CTW_FIA.Models.LocalModels;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;

namespace CTW_FIA.Models
{
    public class ConverterModel
    {
        string GetDisplayName(object obj, string propertyName)
        {
            Type type = obj.GetType();
            var propertyInfo = type.GetProperty(propertyName);

            if (propertyInfo != null)
            {
                var displayAttribute = (DisplayAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(DisplayAttribute));

                if (displayAttribute != null)
                {
                    return displayAttribute.Name;
                }
            }

            return null;
        }
        public List<DisplayModel> getModel(Object data)
        {
            List<DisplayModel> dm = new List<DisplayModel>();
            Type type = data.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                DisplayModel model = new DisplayModel();
                model.PropertName = GetDisplayName(data, property.Name);

                model.PropertValue = Convert.ToString(property.GetValue(data));
                dm.Add(model);

            }
            return dm;
        }
        public List<DisplayModel> GetModelFromDataTable(DataTable data)
        {
            List<DisplayModel> dmList = new List<DisplayModel>();

            foreach (DataColumn column in data.Columns)
            {
                DisplayModel model = new DisplayModel
                {
                    PropertName = column.ColumnName,
                    PropertValue = Convert.ToString(data.Rows[0][column])
                };

                dmList.Add(model);
            }

            return dmList;
        }
    }
}
