const eps = 1e-6;

var x0 = -5; // начальное приближение x0 
var x1 = 5; // начальное приближение x1

while(Math.abs(x1 - x0) > eps)
{
    tmp = (x1 + x0) / 2;

    if (foo(x1) * foo(tmp) < 0)
        x0 = tmp;
    else
        x1 = tmp;
}

console.log(((x1 + x0) / 2).toFixed(6));


function foo(x)
{
    return Math.cos(0.5 * x) - 0.4 * Math.log(x);
}