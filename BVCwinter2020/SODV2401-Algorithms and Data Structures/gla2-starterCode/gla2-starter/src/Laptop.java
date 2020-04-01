/**
 * Represents a simple laptop object.
 *
 * This class should not be modified.
 */
public class Laptop {


    private boolean isBroken;

    public Laptop() {
        this(false);
    } //new laptop

    public Laptop(boolean isBroken) {
        this.isBroken = isBroken;
    }

    public boolean isBroken() {
        return isBroken;
    }

    public void setBroken(boolean broken) {
        isBroken = broken;
    }
}
