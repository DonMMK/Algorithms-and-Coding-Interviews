package com.company;

public class Main {

    public static void main(String pin) {
        // Your code here...

    } //end main method


    public static boolean validatePin(String pin) {


        if (pin.length() == 4 || pin.length() == 6) {
            try {
                int intvalue = Integer.parseInt(pin);
                return true;
            } catch (NumberFormatException e) {
                return false;
            }
        } else return false;
    }

}
