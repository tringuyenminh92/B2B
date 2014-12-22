/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 13/10/2014
	Last Updated: 23/10/2014
	Updated By: Tran Nguyen Hoang Khuyen
	Update Description:
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Model
{
    partial class ChitietPhieuxuatModel
    {
        public string TenHanghoa { get; set; }
        public int? SoluongCanXuat { get; set; }

        public int? SoluongDaXuat { get; set; }

        /// <summary>
        /// Vinh lam, lien quan den phieu giao hang
        /// </summary>
        public string PhantranGiam { get; set; }
        public string VAT { get; set; }
        public string Dongia { get; set; }

    }
}
