
var Calculator = require('../app/calculator');
var calculator = new Calculator();

var chai = require('chai');
var should = chai.should();

module.exports = function() {

    this.Given(/^輸入第一個數字 "([^"]*)"$/, function(first) {
        this.first = +first;
    });

    this.Given(/^輸入第二個數字 "([^"]*)"$/, function(second) {
        this.second = +second;
    });

    this.Given(/^計算時$/, function() {
        this.acutal = calculator.Add(this.first, this.second);
    });

    this.Given(/^結果是 "([^"]*)"$/, function(expacted) {
        (+expacted).should.equal(this.acutal);
    });
}