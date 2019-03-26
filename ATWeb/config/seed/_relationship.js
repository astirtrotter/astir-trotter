'use strict';

module.exports = [
    // parents
    { relation: 'BF', src: 'Father', dst: 'Son' },
    { relation: 'DF', src: 'Father', dst: 'Daughter' },
    { relation: 'BM', src: 'Mother', dst: 'Son' },
    { relation: 'GM', src: 'Mother', dst: 'Daughter' },
    // children (S=HS=WS, D=HD=WD)
    { relation: 'BS', src: 'Son', dst: 'Father' },
    { relation: 'GS', src: 'Son', dst: 'Mother' },
    { relation: 'BD', src: 'Daughter', dst: 'Father' },
    { relation: 'GD', src: 'Daughter', dst: 'Mother' },
    // siblings (FS=MS, FD=MD)
    { relation: 'BFS', src: 'Brother', dst: 'Brother' },
    { relation: 'GFS', src: 'Brother', dst: 'Sister' },
    { relation: 'BFD', src: 'Sister', dst: 'Brother' },
    { relation: 'GFD', src: 'Sister', dst: 'Sister' },
    // spouse
    { relation: 'GH', src: 'Husband', dst: 'Wife' },
    { relation: 'BW', src: 'Wife', dst: 'Husband' },
    // grand parents
    { relation: 'BFF', src: 'Grandfather', dst: 'Grandson' },
    { relation: 'GFF', src: 'Grandfather', dst: 'Granddaughter' },
    { relation: 'BFM', src: 'Grandmother', dst: 'Grandson' },
    { relation: 'GFM', src: 'Grandmother', dst: 'Granddaughter' },
    // uncles, aunts

];