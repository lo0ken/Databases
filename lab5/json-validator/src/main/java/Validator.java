import org.everit.json.schema.Schema;
import org.everit.json.schema.loader.SchemaLoader;
import org.json.JSONObject;
import org.json.JSONTokener;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Validator {

    public static void validateJsonFile(FileInputStream fileInputStream) throws FileNotFoundException {
        JSONObject jsonSchema = new JSONObject(new JSONTokener(new FileInputStream("json-schema.json")));
        Schema schema = SchemaLoader.load(jsonSchema);
        Scanner scanner = new Scanner(fileInputStream);

        JSONObject jsonSubject;
        while (scanner.hasNext()) {
            jsonSubject = new JSONObject(new JSONTokener(scanner.nextLine()));
            schema.validate(jsonSubject);
        }
    }

    public static void main(String[] args) throws FileNotFoundException {
        validateJsonFile(new FileInputStream("hotels.json"));
    }
}
