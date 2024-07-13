using csharp_design_patterns.structural.facade.implementation;

namespace csharp_design_patterns.structural.facade.client;


/*
 The Facade Design Pattern is a structural pattern that provides a simplified interface to a complex subsystem. It offers a higher-level interface that makes the subsystem easier to use and understand.
   
   Components of the Facade Design Pattern
   Facade: Provides a simple interface to the complex subsystem.
   Subsystem Classes: The classes that implement the subsystem functionality. They handle the actual work and complexity.
 
  
 */
public static class Example
{
    public static void ExecuteExample()
    {
        // Create subsystem components
        Amplifier amplifier = new Amplifier();
        DVDPlayer dvdPlayer = new DVDPlayer();
        Projector projector = new Projector();

        // Create the facade
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier, dvdPlayer, projector);

        // Use the facade to watch a movie
        homeTheater.WatchMovie("Inception");

        // Use the facade to end the movie
        homeTheater.EndMovie();
    }

}