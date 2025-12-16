using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERLANDINO_DSAL01E.Lesson_8.Class_Forms
{
    internal class Variables
    {
        public
            Double price,
            cash_given,
            change,
            discount_totalgiven,
            discounted_total,
            discount_amt,
            discounted_amt,
            price_total,
            disc_amnt,
            total_amount,
            cash_rendered = 0;

        public
            Int32 quantity,
            qty_total;

        public
            String picpath;

        public 
            Double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;

        public 
            Double net_income = 0.00,
            gross_income = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 0.00,
            philhealth_contrib = 0.00,
            tax_contrib = 0.00;

        public 
            Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salary_loan = 0.00,
            salary_savings = 0.00,
            faculty_sav_loan = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;
    }
}