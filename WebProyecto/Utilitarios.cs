using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Reflection;

namespace WebTarea6
{
    public class Utilitarios
    {
    }

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