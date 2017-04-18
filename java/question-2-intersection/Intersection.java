**
 * QUESTION 2
 * ==========
 *
 * Complete the function 'findIntersection' below to find the intersection of two arrays. An intersection would be
 * the common elements that exists within both arrays. In this case, make sure that the elements returned are
 * also unique!
 *
 */
 import java.util.Arrays;

 public class Intersection {

     static int[] firstArray = new int[]{2, 2, 4, 1};
     static int[] secondArray = new int[]{1, 2, 0, 2};

     public static int[] findIntersection(int[] arr1, int[] arr2) {

         // TODO: [Your code here]

     }

     public static void main(String args[]) {
         int[] intersection = findIntersection(firstArray, secondArray);
         System.out.println(Arrays.toString(intersection));
     }

 }
