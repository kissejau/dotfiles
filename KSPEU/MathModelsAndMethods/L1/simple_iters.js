const eps = 1e-6;

var x0 = 0;
var x1 = 2; // начальное приближение


while (Math.abs(x1 - x0) > eps)
{
    x0 = x1;
    x1 = foo(x0);
}

console.log(x1.toFixed(6));


function foo(x)
{
    return Math.cos(0.5 * x) - 0.4 * Math.log(x);
}