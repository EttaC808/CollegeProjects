//P04  Monthend Payroll Loops Calculator - Paulette Crawford  
//This program will be used by payroll clerks to determine the total gross pay for the month 
//by processing the weekly hours worked of their employees.  
//This program will not be with calculating taxes and net pay

#include <iostream>  // cin and cout
using namespace std;

#include <stdlib.h>    // system()


int main()
{
//declare constants
//RATE1 is not actually used in the program, but is declared here
//for clarification on the 3 different rates.  RATE1 is not used
//because it is equal to one and multiplying by one gives the same value.
    const double RATE1 = 1.0, RATE2 = 1.5, RATE3 = 2.0;

//declare variables
    int empCount, loopCount;
    int w1Hours, w2Hours, w3Hours, w4Hours, employeeHours, reportNumHours = 0;

    double rate, empAverage;

    double w1Pay1, w1Pay2, w1Pay3, emp1Total;
    double w2Pay1, w2Pay2, w2Pay3, emp2Total;
    double w3Pay1, w3Pay2, w3Pay3, emp3Total;
    double w4Pay1, w4Pay2, w4Pay3, emp4Total;

    double empPay1, empPay2, empPay3, empTotal;

    //initialize accumulators to zero
    double reportHours = 0, reportPay1 = 0, reportPay2 = 0,
        reportPay3 = 0, reportTotal = 0;

    bool weekError;
    char prompt;

    //Set decimal formatting
    cout.setf(ios::fixed);
    cout.setf(ios::showpoint);
    cout.precision(2);

    cout << "P04 - Paulette Crawford\n\n";

    //get empCount (do-while)

    //Get employee count
//do-while is processed until a valid empCount is entered (0 or greater)
    do
    {
        cout
            << "Enter the number of employees to process. \n"
            << "Enter 0 (zero) to exit: ";

        cin >> empCount;

        if (empCount < 0)
            cout << "Error: The number of employes to "
            << "process must be 0 or greater. Try again.\n\n";
    } while (empCount < 0);

    //Set the loopCounter to one
    loopCount = 1;
    while (loopCount <= empCount)
    {
        //Display which employee we are currently processing
        cout << "\nP04 - Paulette Crawford                   \t\tEmployee: "
            << loopCount << endl << endl;
        //get rate (do-while)
        do
        {
            cout << "Enter a rate between $5.25 and $30.00: ";
            cin >> rate;

            if (rate < 5.25 || rate > 30.00)
                cout << "Error: The rate must be between $5.25 and $30.00.\n\n";

        } while (rate < 5.25 || rate > 30.00);

        //get hours w1, w2, w3, w4  (do-while)
        /*
 Get the hours for each of the four weeks and validate them.
 None of them can be < zero.
 None can be > 60
*/
        do
        {
            weekError = false;  // assume correct values will be entered

            cout << "Enter four hours worked separated by a space (0 - 60): ";
            cin >> w1Hours >> w2Hours >> w3Hours >> w4Hours;

            if ((w1Hours < 0) || (w2Hours < 0) || (w3Hours < 0) || (w4Hours < 0))
            {
                cout << "Error: Negative values are not valid.\n\n";
                weekError = true;
            }
            if ((w1Hours > 60) || (w2Hours > 60) || (w3Hours > 60) || (w4Hours > 60))
            {
                cout << "Error: Values may not exceed 60.\n\n";
                weekError = true;
            }
        } while (weekError);

        //calculate pay for 4 weeks 

        //Calculate pay
//Create four pay calculation formulas, one for each week W1, W2, W3, and W4.

//Week1
        if (w1Hours <= 40)
        {
            w1Pay1 = w1Hours * rate;
            w1Pay2 = 0;
            w1Pay3 = 0;
        }
        else
        {
            if (w1Hours <= 50)
            {
                w1Pay1 = 40 * rate;
                w1Pay2 = (w1Hours - 40) * rate * RATE2;
                w1Pay3 = 0;
            }
            else
            {
                w1Pay1 = 40 * rate;
                w1Pay2 = 10 * rate * RATE2;
                w1Pay3 = (w1Hours - 50) * rate * RATE3;
            }//else
        }//else

        //Week2
        if (w2Hours <= 40)
        {
            w2Pay1 = w2Hours * rate;
            w2Pay2 = 0;
            w2Pay3 = 0;
        }
        else
        {
            if (w2Hours <= 50)
            {
                w2Pay1 = 40 * rate;
                w2Pay2 = (w2Hours - 40) * rate * RATE2;
                w2Pay3 = 0;
            }
            else
            {
                w2Pay1 = 40 * rate;
                w2Pay2 = 10 * rate * RATE2;
                w2Pay3 = (w2Hours - 50) * rate * RATE3;
            }//else
        }//else

        //Week3
        if (w3Hours <= 40)
        {
            w3Pay1 = w3Hours * rate;
            w3Pay2 = 0;
            w3Pay3 = 0;
        }
        else
        {
            if (w3Hours <= 50)
            {
                w3Pay1 = 40 * rate;
                w3Pay2 = (w3Hours - 40) * rate * RATE2;
                w3Pay3 = 0;
            }
            else
            {
                w3Pay1 = 40 * rate;
                w3Pay2 = 10 * rate * RATE2;
                w3Pay3 = (w3Hours - 50) * rate * RATE3;
            }//else
        }//else

        //Week4
        if (w4Hours <= 40)
        {
            w4Pay1 = w4Hours * rate;
            w4Pay2 = 0;
            w4Pay3 = 0;
        }
        else
        {
            if (w4Hours <= 50)
            {
                w4Pay1 = 40 * rate;
                w4Pay2 = (w4Hours - 40) * rate * RATE2;
                w4Pay3 = 0;
            }
            else
            {
                w4Pay1 = 40 * rate;
                w4Pay2 = 10 * rate * RATE2;
                w4Pay3 = (w4Hours - 50) * rate * RATE3;
            }//else
        }//else

        //sum week totals (cross foot)
        emp1Total = w1Pay1 + w1Pay2 + w1Pay3;
        emp2Total = w2Pay1 + w2Pay2 + w2Pay3;
        emp3Total = w3Pay1 + w3Pay2 + w3Pay3;
        emp4Total = w4Pay1 + w4Pay2 + w4Pay3;

        //sum emp totals (columns)
        empPay1 = w1Pay1 + w2Pay1 + w3Pay1 + w4Pay1;
        empPay2 = w1Pay2 + w2Pay2 + w3Pay2 + w4Pay2;
        empPay3 = w1Pay3 + w2Pay3 + w3Pay3 + w4Pay3;

        empTotal = emp1Total + emp2Total + emp3Total + emp4Total;

        employeeHours = w1Hours + w2Hours + w3Hours + w4Hours;

        //accumulate report totals
//Shorthand notation  += and -=
//+= means to add the value in the variable on the left to the one on the right
//and to store the result back in the variable on the left.
//      reportTotal1  = reportTotal1 + salespersonTotal1;

        reportPay1 += empPay1;
        reportPay2 += empPay2;
        reportPay3 += empPay3;
        reportTotal += empTotal;

        reportNumHours += employeeHours;

        //display headings
        cout << endl
            << "Week \tRate \tHours \t1.0 \t1.5 \t2.0 \tTotal \n\n"

        //display detail lines (4 weeks)
            << "W1 \t" << rate << "\t" << w1Hours << "\t" << w1Pay1 << "\t"
            << w1Pay2 << "\t" << w1Pay3 << "\t" << emp1Total << endl

            << "W2 \t" << rate << "\t" << w2Hours << "\t" << w2Pay1 << "\t"
            << w2Pay2 << "\t" << w2Pay3 << "\t" << emp2Total << endl

            << "W3 \t" << rate << "\t" << w3Hours << "\t" << w3Pay1 << "\t"
            << w3Pay2 << "\t" << w3Pay3 << "\t" << emp3Total << endl

            << "W4 \t" << rate << "\t" << w4Hours << "\t" << w4Pay1 << "\t"
            << w4Pay2 << "\t" << w4Pay3 << "\t" << emp4Total << endl
            << endl

        //display employee totals
            << "Employee Totals\t" << employeeHours
            << "\t" << empPay1
            << "\t" << empPay2
            << "\t" << empPay3
            << "\t" << empTotal
            << endl << endl

            << "Press Enter to process the next employee or Report Totals: ";
        cin.ignore();
        prompt = cin.get();

        system("cls");        //clear screen for next employee

        //display continue prompt

        loopCount++;
    } //end of while (loopCount < empCount)

    //calculate average
    //Before dividing by empCount, make sure it is not equal to zero.
    if (empCount > 0)
        empAverage = reportTotal / empCount;
    else
        empAverage = 0;

    //display report totals
    cout << endl
        << "        \tHours \t1.0 \t1.5 \t2.0 \tTotal "
        << "\nReport Totals: \t" << reportNumHours
        << "\t" << reportPay1
        << "\t" << reportPay2
        << "\t" << reportPay3
        << "\t" << reportTotal
        << endl << endl

    //display empCount and average
        << "Number of Employees:   \t" << empCount 
        << "\tAverage Gross:  " << empAverage << endl << endl;
    return 0;
}// end of main

