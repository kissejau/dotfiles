// NEWTON

const eps = 1e-6;
const _x = 2; // начальное приближение

var xn = _x - ( Math.cos(0.5 * _x) - 0.4 * Math.log(_x) ) / ( ( Math.sin(1/2*_x) ) / 2 - ( 2 / 5 * _x ) );
var xni = xn - ( Math.cos(0.5 * xn) - 0.4 * Math.log(xn) ) / ( ( Math.sin(1/2*xn) ) / 2 - ( 2 / 5 * xn ) );

while (xn - xni >= eps)
{
    xn = xni;
    xni = xn - ( Math.cos(0.5 * xn) - 0.4 * Math.log(xn) ) / ( ( Math.sin(1/2*xn) ) / 2 - ( 2 / 5 * xn ) );
}

console.log(xni.toFixed(6));
