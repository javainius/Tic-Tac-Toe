﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacDB.Models;

namespace Tic_Tac_Toe.Models
{
    public class TicTacViewModel
    {       
        public List<Row> Rows { get; set; }
        public TicTacViewModel(List<GridModel> rows)
        {
            Rows = new List<Row>();
            foreach(var row in rows)
            {
                Rows.Add(new Row(row.FirstColumn, row.SecondColumn, row.ThirdColumn));
            }
        }
    }
    public class Row
    {
        public string FirstElement { get; set; }
        public string SecondElement { get; set; }
        public string ThirdElement { get; set; }
        public Row(string FirstElement, string SecondElement, string ThirdElement)
        {
            this.FirstElement = FirstElement;
            this.SecondElement = SecondElement;
            this.ThirdElement = ThirdElement;
        }
    }
}
