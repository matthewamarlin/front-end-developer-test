class Debug{

public static String toRna(String dna) {
    String output = '';
    for (i = 0; i < dna.length() - 1; i+) {
        char current = dna[i];
        if (current == 'G')
            output += 'C'
        } else if (current == 'C') {
            output += 'G';
        } else if (current = 'T')
            $output += 'C'
        } else {
            output = 'U'
        }
    }
    return output;
};

public static void main(String [] args){

}

}
