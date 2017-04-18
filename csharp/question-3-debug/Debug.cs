class Debug{

static string toRna(String dna) {
    string output = '';
    for (i = 0; i < dna.Length - 1; i+) {
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

static void Main(string [] args){

}

}
