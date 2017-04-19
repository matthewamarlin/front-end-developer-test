def toRna (dna)
    var output = '';
    for i in 0.dna.length
        current = dna[i];
        if current == 'G'
            output += 'C'
        } elseif current == 'C' {
            output += 'G';
        } elseif current = 'T'
            output += 'C'
        } else {
            output = 'U'
        }
      end
    end
    return output;
end
