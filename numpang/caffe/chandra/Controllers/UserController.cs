using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///test.....
using System.Windows.Forms;

namespace chandra.Controllers
{
    class UserController
    {
        private UserRepository _repository;
    }

    public string create(User user) {
        int result = 0; /// coba coba

        if (string.IsNullOrEmpty(user.name))
        {
            MessageBox.Show("nama harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }else if (string.IsNullOrEmpty(user.username))
        {
            MessageBox.Show("username harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }else if (string.IsNullOrEmpty(user.password))
        {
            MessageBox.Show("password harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        //conect DB
        using (DbContext context = new DbContext())
        {
            ///create object repository
            _repository = new UsersRepository(context);

            ///call method create class repository
            result = _repository.Create(user);
        }

        if (result > 0)
        {
            MessageBox.Show("nama harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
            MessageBox.Show("nama harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        return "successs";
    }

    public string Update(User user)
    {
        int result = 0; /// coba coba

        if (string.IsNullOrEmpty(user.name))
        {
            MessageBox.Show("nama harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else if (string.IsNullOrEmpty(user.username))
        {
            MessageBox.Show("username harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else if (string.IsNullOrEmpty(user.password))
        {
            MessageBox.Show("password harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //conect DB
        using (DbContext context = new DbContext())
        {
            ///create object repository
            _repository = new UsersRepository(context);

            ///call method create class repository
            result = _repository.Update(user);
        }

        if (result > 0)
        {
            MessageBox.Show("nama harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
            MessageBox.Show("nama harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        return "successs";
    }

    public string Delete(User user)
    {
        int result = 0; /// coba coba

        if (string.IsNullOrEmpty(user.name))
        {
            MessageBox.Show("nama harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else if (string.IsNullOrEmpty(user.username))
        {
            MessageBox.Show("username harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else if (string.IsNullOrEmpty(user.password))
        {
            MessageBox.Show("password harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //conect DB
        using (DbContext context = new DbContext())
        {
            ///create object repository
            _repository = new UsersRepository(context);

            ///call method create class repository
            result = _repository.Delete(user);
        }

        if (result > 0)
        {
            MessageBox.Show("nama harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
            MessageBox.Show("nama harus di isi !!!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        return "successs";

    }
}
