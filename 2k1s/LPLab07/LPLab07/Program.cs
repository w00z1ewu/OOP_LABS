using System;
using System.Diagnostics;

namespace LPLab07
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            try
            {
                int p = 3;
                p /= 0;
                Rectangle pp = new Rectangle();
            }
            catch(ControlElementException error)
            {
                error.Display();
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            catch
            {
                Console.WriteLine("Unknown exception.");
            }
            finally
            {
                Console.WriteLine($"Exception №{++counter} has been tested.");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                Rectangle pp = new Rectangle();
                pp.setcoords(-1, 3);
            }
            catch (ControlElementException error)
            {
                error.Display();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            catch
            {
                Console.WriteLine("Unknown exception.");
            }
            finally
            {
                Console.WriteLine($"Exception №{++counter} has been tested.");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            try
            {
                RadioButton rb = new RadioButton();
                rb.setcoords(3, 5);
                rb.resize(3, -1);
            }
            catch (ControlElementException error)
            {
                error.Display();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            catch
            {
                Console.WriteLine("Unknown exception.");
            }
            finally
            {
                Console.WriteLine($"Exception №{++counter} has been tested.");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            try
            {
                Circle c = new Circle();
                c.setcoords(1, 5);
                c.resize(-20);
            }
            catch (ControlElementException error)
            {
                error.Display();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            catch
            {
                Console.WriteLine("Unknown exception.");
            }
            finally
            {
                Console.WriteLine($"Exception №{++counter} has been tested.");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                CheckBox cb = new CheckBox();
                cb.setcolor(0xFFAADDDD);
                cb.setcoords(2, 4);
                cb.setvalue("This is checkbox");
               // cb.resize(0);
            }
            catch (ControlElementException error)
            {
                error.Display();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            catch
            {
                Console.WriteLine("Unknown exception.");
            }
            finally
            {
                Console.WriteLine($"Exception №{++counter} has been tested.");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;

            int var = 5;

            Debug.Assert(var<3, "varuable's value is more than 3");
        }
    }
}
