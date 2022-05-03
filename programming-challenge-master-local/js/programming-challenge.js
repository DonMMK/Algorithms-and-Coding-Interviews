class Program {

    _phrases = {
        "Hello": "Ellohay",
        "Pig Latin": "Igpay Atinlay",
        "The first month is Janurary": "Ethay irstfay onthmay isway Anuraryjay",
        "The floor is sticky": "Ethay oorflay isway ickystay"
    }

    constructor() {
        for (let english in this._phrases) {
            this._testEquals(english, this._phrases[english], this._translateEnglishToPigLatin(english));
        }
    }

    _translateEnglishToPigLatin(english) {
        // TODO
        const translator = () => {
            const translating = input.replace(/\b(\w)(\w+)\b/g, function(
                match,
                p1,
                p2
            ) {
                if (/[aeiou]/i.test(p1)) {
                    return (p2 = match + "way");
                }
                if (/[A-Z]/.test(p1)) {
                    p2 = p2.replace(/^\w/, function(x) {
                        return x.toUpperCase();
                    });
                    return p2 + p1.toLowerCase() + "ay";
                } else {
                    return p2 + p1 + "ay";
                }
            });
        };
        return translator();

    }

    _testEquals(input, expect, actual) {
        if (expect.toLowerCase() == actual.toLowerCase()) {
            if (expect != expect.toLowerCase() && expect == actual) {
                console.log("PASS (Bonus)! " + input + " -> " + actual);
            } else {
                console.log("PASS! " + input + " -> " + actual);
            }
        } else {
            console.log("FAIL!");
            console.log("  Input: " + input);
            console.log("  Expect: " + expect);
            console.log("  Actual: " + actual);
        }
    }

}

new Program();