import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

public class Main {
    static final String DB_URL = "jdbc:postgresql://localhost:5432/hotels";
    static final String USER = "postgres";
    static final String PASS = "1";

    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        createScalarFunc();
        createAggregateFunc();
        createTableFunc();
        createProcedure();
        createTrigger();
        createType();
    }


    public static void createScalarFunc() {
        String query = "CREATE OR REPLACE FUNCTION scalarFunc(\n" +
                "\t)\n" +
                "    RETURNS character varying\n" +
                "    LANGUAGE 'sql'\n" +
                "\n" +
                "    COST 100\n" +
                "    VOLATILE \n" +
                "    \n" +
                "AS $BODY$\n" +
                "\tselect hotelName\n" +
                "\tfrom hotels\n" +
                "\torder by hotelName\n" +
                "$BODY$;\n" +
                "\n" +
                "ALTER FUNCTION public.a1()\n" +
                "    OWNER TO postgres;\n";

        try (Connection connection = DriverManager.getConnection(DB_URL, USER, PASS)){
            Statement statement = connection.createStatement();
            statement.execute(query);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public static void createAggregateFunc() {
        String query = "CREATE OR REPLACE FUNCTION public.find_the_most_expensive_roomid(\n" +
                "\t)\n" +
                "    RETURNS integer\n" +
                "    LANGUAGE 'sql'\n" +
                "\n" +
                "    COST 100\n" +
                "    IMMUTABLE \n" +
                "    \n" +
                "AS $BODY$\n" +
                "\t\tselect rooms.Id\n" +
                "\t\tfrom rooms\n" +
                "\t\twhere rooms.cost in (select max(cost) from rooms);\n" +
                "\t$BODY$;";

        try (Connection connection = DriverManager.getConnection(DB_URL, USER, PASS)){
            Statement statement = connection.createStatement();
            statement.execute(query);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public static void createTableFunc() {
        String query = "CREATE OR REPLACE FUNCTION public.gethotel(\n" +
                "\tinteger)\n" +
                "    RETURNS hotels\n" +
                "    LANGUAGE 'sql'\n" +
                "\n" +
                "    COST 100\n" +
                "    VOLATILE \n" +
                "    \n" +
                "AS $BODY$\n" +
                "\tselect * from hotels\n" +
                "\twhere id = $1;\n" +
                "$BODY$;";

        try (Connection connection = DriverManager.getConnection(DB_URL, USER, PASS)){
            Statement statement = connection.createStatement();
            statement.execute(query);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public static void createProcedure() {
        String query = "CREATE OR REPLACE PROCEDURE public.update_cost(\n" +
                "\tnew_cost integer,\n" +
                "\tid_l integer,\n" +
                "\tid_h integer)\n" +
                "LANGUAGE 'plpgsql'\n" +
                "\n" +
                "AS $BODY$\n" +
                "begin\n" +
                "\tif (id_l <= id_h)\n" +
                "then\n" +
                "\tupdate rooms_copy\n" +
                "\tset cost = new_cost\n" +
                "\twhere id = id_l;\n" +
                "\tcall update_cost(new_cost, id_l + 1, id_h);\n" +
                "end if; \n" +
                "end;\n" +
                "\t\n" +
                "$BODY$;";

        try (Connection connection = DriverManager.getConnection(DB_URL, USER, PASS)){
            Statement statement = connection.createStatement();
            statement.execute(query);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public static void createTrigger() {
        String query = "CREATE or REPLACE FUNCTION public.hotelname_log_func()\n" +
                "    RETURNS trigger\n" +
                "    LANGUAGE 'plpgsql'\n" +
                "    COST 100\n" +
                "    VOLATILE NOT LEAKPROOF\n" +
                "AS $BODY$\n" +
                "   begin\n" +
                "      insert into hotelname_changes_audit(change_id, change_date) values (new.id, current_timestamp);\n" +
                "      return new;\n" +
                "   end;\n" +
                "$BODY$;";

        try (Connection connection = DriverManager.getConnection(DB_URL, USER, PASS)){
            Statement statement = connection.createStatement();
            statement.execute(query);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public static void createType() {
        String query = "CREATE TYPE bug_status AS ENUM ('new', 'open', 'closed');";

        try (Connection connection = DriverManager.getConnection(DB_URL, USER, PASS)){
            Statement statement = connection.createStatement();
            statement.execute(query);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
