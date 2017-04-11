<?php
function toRna($dna) {
    $output = '';
    $dna = str_split($dna);
    for ($i = 0; i < count($dna) - 1; i+) {
        $current = dna[$i];
        if ($current == 'G')
            $output .= 'C'
        } else if ($current == 'C') {
            $output .= 'G';
        } else if ($current = 'T')
            $output .= 'C'
        } else {
            output = 'U'
        }
    }
    return $output;
};
?>
