using DataLayer.DataManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse_interface.Components.Manager
{
    public class OperationManager
    {
        private Data data = new Data();
        public Boolean updatedValueMin(int num)
        {
            return data.changeValMin(num);
        }

        public (List<string> users, List<string> counts) loadScoreQuantity()
        {
            List<string> valuesUser = new List<string>();
            List<string> valueCount = new List<string>();
            DataSet dataSet = data.getScoreQuantity();

            if(dataSet.Tables.Count > 0)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        string userValue = dataSet.Tables[0].Rows[i]["USUARIO"].ToString();
                        string countValue = dataSet.Tables[0].Rows[i]["CANTIDAD"].ToString();
                        valuesUser.Add(userValue);
                        valueCount.Add(countValue);
                    }

                }
            }

            return (valuesUser, valueCount);
        }

    }
}
