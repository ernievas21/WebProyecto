
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebTarea6
{
    public class Utilitario
    {

        public List<T> ConvertirDataTable<T>(DataTable dtDatos)
        {
            List<T> data = new List<T>();

            foreach (DataRow rowData in dtDatos.Rows)
            {
                T item = ObterItem<T>(rowData);
                data.Add(item);
            }

            return data;

        }

        private T ObterItem<T>(DataRow drDatos)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in drDatos.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, drDatos[column.ColumnName], null);
                    else
                        continue;
                }
            }

            return obj;
        }







    }

  






}

