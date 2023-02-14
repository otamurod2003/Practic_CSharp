using _12_Interface;

class Employee: Human
{
    private decimal _maosh;

    public decimal Maosh { get; set; }

    public Employee(int boyi, int vazni , decimal maosh)
        : base(boyi, vazni)

    {
        _maosh= maosh;
    }

    public Employee()
    {

    }

}