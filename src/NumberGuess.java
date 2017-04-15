import java.util.*;

public class NumberGuess {
    public static int StartGuess(int upperBound)
    {
        Scanner in = new Scanner(System.in);
        int middle;
        String answer = "";
        int low = 0;
        int high = upperBound;
        while (low < high)
        {
            middle = (low + high) /2;
            System.out.printf("Ваше число больше %d?\n", middle);
            answer = in.next();
            switch (answer.charAt(0))
            {
                case 'Y':
                case 'y':
                    if (middle >= low)
                        low = middle + 1;
                    break;
                case 'N':
                case 'n':
                    if (middle <= high)
                        high = middle;
                    break;
                default:
                    System.out.printf("Не удалось распознать ответ! Попробуйте ответить \"Yes\" или \"No\".\n");
                    break;
            }
        }
        if (low == upperBound) {
            while(true)
            {
                System.out.printf("Ваше число больше %d?\n", upperBound);
                answer = in.next();
                switch (answer.charAt(0)) {
                    case 'Y':
                    case 'y':
                        System.out.printf("Неправда! Вам нужно было загадать число от 0 до %d!\n", upperBound);
                        return -1;
                    case 'N':
                    case 'n':
                        return low;
                    default:
                        System.out.printf("Не удалось распознать ответ! Попробуйте ответить \"Yes\" или \"No\".\n");
                        break;
                }
            }
        }
        if (low == 0)
        {
            while (true) {
                System.out.printf("Ваше число меньше 0?\n");
                answer = in.next();
                switch (answer.charAt(0)) {
                    case 'Y':
                    case 'y':
                        System.out.printf("Неправда! Вам нужно было загадать число от 0 до %d!\n", upperBound);
                        return -1;
                    case 'N':
                    case 'n':
                        return low;
                    default:
                        System.out.printf("Не удалось распознать ответ! Попробуйте ответить \"Yes\" или \"No\".\n");
				        break;
                }
            }
        }
        return low;
    }
}