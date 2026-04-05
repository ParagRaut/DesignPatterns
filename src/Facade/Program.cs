using Facade;

// Without facade: you'd need to call 8+ methods in the right order
// With facade: one call does it all

var homeTheater = new HomeTheaterFacade(
    new Television(),
    new SoundSystem(),
    new StreamingPlayer(),
    new Lights()
);

homeTheater.WatchMovie("Interstellar");
homeTheater.EndMovie();
