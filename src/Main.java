import java.io.IOException;
import java.util.Scanner;

/**
 * Created by User on 15.04.2017.
 */
public class Main {
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        System.out.printf("Hello!\n" +
                "I'm welcome you in the game \"Guess a Number\"!\n" +
                "This game is going to guess a number, you imagine, asking your some questions.\n" +
                "You can answer \"Yes\" or \"No\". Be honest!\n" +
                "So, now guess a positive integer in range 0 to %d.", MAX_VALUE);
        System.out.printf("\n\n");
        int answer = NumberGuess.StartGuess(MAX_VALUE);
        if (answer >= 0)
        {
            System.out.printf("Your number is %d !\n", answer);
        }
    }

    private static int MAX_VALUE = 100;
}
