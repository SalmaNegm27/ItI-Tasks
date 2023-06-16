var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//1
var numaarr = [];
function arrayOfNumber(num) {
    if (typeof num === 'number') {
        numaarr.push(num.toString());
    }
}
arrayOfNumber(1);
arrayOfNumber(20);
arrayOfNumber(30);
console.log(numaarr);
//2
var myArray = ['Hello', 2, 'World', 4];
for (var _i = 0, myArray_1 = myArray; _i < myArray_1.length; _i++) {
    var item = myArray_1[_i];
    console.log(typeof item);
}
//3
var enumValues;
(function (enumValues) {
    enumValues[enumValues["First"] = 1] = "First";
    enumValues[enumValues["second"] = 2] = "second";
    enumValues[enumValues["third"] = 3] = "third";
    enumValues[enumValues["Fourth"] = 4] = "Fourth";
})(enumValues || (enumValues = {}));
console.log(enumValues.First);
console.log(enumValues.second);
console.log(enumValues.third);
console.log(enumValues.Fourth);
function func(arg1, arg2) {
    if (typeof arg1 === 'string' && typeof arg2 === 'string') {
        return arg1 + ' ' + arg2;
    }
    else if (typeof arg1 === 'number' && typeof arg2 === 'number') {
        return arg1 + arg2;
    }
    else if (typeof arg1 === 'string' && typeof arg2 === 'number') {
        console.log("Name: ".concat(arg1, ", Age: ").concat(arg2));
        return "";
    }
    else {
        throw new Error('Invalid arguments');
    }
}
console.log(func('Salama', 'Negm'));
console.log(func(2, 3));
func('Mohamed', 25);
console.log(func('Salma', 25));
var Employee = /** @class */ (function () {
    function Employee(id, username, name, email, address) {
        this.id = id;
        this.username = username;
        this.name = name;
        this.email = email;
        this.address = address;
    }
    Employee.prototype.getAddressString = function () {
        return "".concat(this.address.street, ", ").concat(this.address.suite, ", ").concat(this.address.city, ", ").concat(this.address.zipcode);
    };
    return Employee;
}());
var employeeData = {
    id: 1,
    name: "Leanne Graham",
    username: "Bret",
    email: "Sincere@april.biz",
    address: {
        street: "Kulas Light",
        suite: "Apt. 556",
        city: "Gwenborough",
        zipcode: "92998-3874",
        geo: {
            lat: "-37.3159",
            lng: "81.1496"
        }
    }
};
var employee = new Employee(employeeData.id, employeeData.username, employeeData.email, employeeData.name, employeeData.address);
console.log(employee);
var Manager = /** @class */ (function (_super) {
    __extends(Manager, _super);
    function Manager(id, username, name, email, address) {
        return _super.call(this, id, username, email, name, address) || this;
    }
    Manager.prototype.viewEmployeeAddress = function (employee) {
        console.log("Employee Address: ".concat(employee.getAddressString()));
    };
    return Manager;
}(Employee));
