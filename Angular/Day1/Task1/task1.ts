//1
let numaarr: string[] = [];

function arrayOfNumber(num: number): void {
    if (typeof num === 'number') {
        numaarr.push(num.toString());
    }
}
arrayOfNumber(1)
arrayOfNumber(20)
arrayOfNumber(30)
console.log(numaarr)

//2
let myArray: (string | number)[] = ['Hello', 2, 'World', 4];

for (let item of myArray) {
    console.log(typeof item);
}
//3
enum enumValues {
    First = 1,
    second = 2,
    third = 3,
    Fourth = 4,
}
console.log(enumValues.First)
console.log(enumValues.second)
console.log(enumValues.third)
console.log(enumValues.Fourth)
//4
type numb = string | number
//5

function func(fname: string, lname: string): string;
function func(num1: number, num2: number): number;
function func(arg1: string, arg2: number): string;
function func(arg1: string | number, arg2: string | number): string | number {
    if (typeof arg1 === 'string' && typeof arg2 === 'string') {
        return arg1 + ' ' + arg2;
    } else if (typeof arg1 === 'number' && typeof arg2 === 'number') {
        return arg1 + arg2;
    } else if (typeof arg1 === 'string' && typeof arg2 === 'number') {
        console.log(`Name: ${arg1}, Age: ${arg2}`);
        return "";
    } else {
        throw new Error('Invalid arguments');
    }
}

console.log(func('Salama', 'Negm'));
console.log(func(2, 3));
func('Mohamed', 25);

console.log(func('Salma', 25));

// 6
interface IEmployee {
    id: number;
    username: string;
    name: string;
    email: string,
    address: {
        street: string;
        suite: string;
        city: string;
        zipcode: string;
        geo: {
            lat: string;
            lng: string;
        };
    };
}

class Employee implements IEmployee {
    constructor(
        public readonly id: number,
        private username: string,
        public name: string,
        public email: string
      protected address: {
            street: string;
            suite: string;
            city: string;
            zipcode: string;
            geo: {
                lat: string;
                lng: string;
            };
        }
    ) {}
    public getAddressString(): string {
        return `${this.address.street}, ${this.address.suite}, ${this.address.city}, ${this.address.zipcode}`;
      }
}
const employeeData = {
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

const employee = new Employee(
    employeeData.id,
    employeeData.username,
    employeeData.email,
    employeeData.name,
    employeeData.address
);
console.log(employee)

class Manager extends Employee {
    constructor(
        id: number,
        username: string,
        name: string,
        email: string,
        address: {
            street: string;
            suite: string;
            city: string;
            zipcode: string;
            geo: {
                lat: string;
                lng: string;
            };
        }
    ) {
        super(id, username, email, name, address);
    }

    viewEmployeeAddress(employee: Employee): void {
        console.log(`Employee Address: ${employee.getAddressString()}`);
      }
}
