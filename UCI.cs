using System;

public static class UCI {
    public static void Loop() {
        while (true) {
            string input = Console.ReadLine();
            if (input == null) continue;

            if (input == "uci") {
                Console.WriteLine("id name Cheese");
                Console.WriteLine("id author Mudit");
                Console.WriteLine("uciok");
            }
            else if (input == "isready") {
                Console.WriteLine("readyok");
            }
            else if (input.StartsWith("position")) {
                PositionHandler(input);
            }
            else if (input.StartsWith("go")) {
                GoHandler();
            }
            else if (input == "quit") {
                break;
            }
        }
    }

    static void PositionHandler(string input) {
        // e.g., "position startpos moves e2e4 e7e5"
        // Parse and update board state here using your Board class
    }

    static void GoHandler() {
        // Call your search method and print the best move like:
        // Console.WriteLine("bestmove e2e4");
    }
}
