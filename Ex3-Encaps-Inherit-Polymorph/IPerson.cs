namespace Ex3_Encaps_Inherit_Polymorph
{
    interface IPerson
    {
        int Age { get; set; }
        string Name { get; set; }
        double Weight { get; set; }

        string DoSound();

        string Talk();
    }
}