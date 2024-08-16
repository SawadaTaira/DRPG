using System;
using System.Linq;
using System.Windows.Forms;
using static DRPG.Enemy;
using static DRPG.Hero;

namespace DRPG
{
    public partial class Form1 : Form
    {
        private Character[] heroes;
        private Character[] enemies;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            InitializeBattle();
            random = new Random();
        }

        private void InitializeBattle()
        {
            heroes = new Character[]
            {
                new Warrior(),
                new Mage(),
                new Archer()
            };

            enemies = new Character[]
            {
                new Goblin(),
                new Dullahan(),
                new Dragon()
            };

            // 味方と敵のHPバーの設定
            pbHero1.Maximum = heroes[0].HP;
            pbHero1.Value = heroes[0].HP;
            pbHero2.Maximum = heroes[1].HP;
            pbHero2.Value = heroes[1].HP;
            pbHero3.Maximum = heroes[2].HP;
            pbHero3.Value = heroes[2].HP;

            pbEnemy1.Maximum = enemies[0].HP;
            pbEnemy1.Value = enemies[0].HP;
            pbEnemy2.Maximum = enemies[1].HP;
            pbEnemy2.Value = enemies[1].HP;
            pbEnemy3.Maximum = enemies[2].HP;
            pbEnemy3.Value = enemies[2].HP;

            // ラベルにキャラクター名を設定
            lblHero1.Text = heroes[0].Name;
            lblHero2.Text = heroes[1].Name;
            lblHero3.Text = heroes[2].Name;

            lblEnemy1.Text = enemies[0].Name;
            lblEnemy2.Text = enemies[1].Name;
            lblEnemy3.Text = enemies[2].Name;

            lstHeroes.Items.Clear();
            foreach (var hero in heroes)
            {
                lstHeroes.Items.Add(hero.Name);
            }

            lstEnemies.Items.Clear();
            foreach (var enemy in enemies)
            {
                lstEnemies.Items.Add(enemy.Name);
            }

            btnAttack.Enabled = true;
            txtResult.Clear();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (lstHeroes.SelectedItem != null && lstEnemies.SelectedItem != null)
            {
                string selectedHeroName = lstHeroes.SelectedItem.ToString();
                string selectedEnemyName = lstEnemies.SelectedItem.ToString();

                Character attacker = Array.Find(heroes, h => h.Name == selectedHeroName);
                Character target = Array.Find(enemies, e => e.Name == selectedEnemyName);

                if (attacker.HP == 0)
                {
                    MessageBox.Show($"{attacker.Name} は倒れているため選択できません。");
                    lstHeroes.ClearSelected();
                    return;
                }

                if (target.HP == 0)
                {
                    MessageBox.Show($"{target.Name} は倒れているため選択できません。");
                    lstEnemies.ClearSelected();
                    return;
                }

                if (attacker != null && target != null)
                {
                    attacker.YourTurn(target);
                    string result = $"{attacker.Name} は {target.Name} に攻撃 - {target.Name} のHPは {target.HP} になった\r\n";

                    if (target.HP == 0)
                    {
                        result += $"{target.Name} は倒された！\r\n";
                    }

                    txtResult.AppendText(result);
                    UpdateHPBars();

                    if (CheckVictory())
                    {
                        return;
                    }

                    EnemyAttack();
                }
            }
            else
            {
                MessageBox.Show("攻撃する味方と敵を選択してください。");
            }
        }


        private void EnemyAttack()
        {
            var livingEnemies = enemies.Where(e => e.HP > 0).ToArray();
            if (livingEnemies.Length > 0)
            {
                var enemy = livingEnemies[random.Next(livingEnemies.Length)];

                var livingHeroes = heroes.Where(h => h.HP > 0).ToArray();
                if (livingHeroes.Length > 0)
                {
                    var target = livingHeroes[random.Next(livingHeroes.Length)];
                    enemy.YourTurn(target);
                    string result = $"{enemy.Name} は {target.Name} に攻撃 - {target.Name} のHPは {target.HP} になった\r\n";

                    if (target.HP == 0)
                    {
                        result += $"{target.Name} は倒された！\r\n";
                    }

                    txtResult.AppendText(result);
                    UpdateHPBars();

                    CheckVictory();
                }
            }
        }

        private void UpdateHPBars()
        {
            // 味方と敵のHPバーを更新
            pbHero1.Value = heroes[0].HP;
            pbHero2.Value = heroes[1].HP;
            pbHero3.Value = heroes[2].HP;

            pbEnemy1.Value = enemies[0].HP;
            pbEnemy2.Value = enemies[1].HP;
            pbEnemy3.Value = enemies[2].HP;
        }

        private bool CheckVictory()
        {
            bool allHeroesDefeated = heroes.All(h => h.HP == 0);
            bool allEnemiesDefeated = enemies.All(e => e.HP == 0);

            if (allHeroesDefeated)
            {
                txtResult.AppendText("味方は全滅した！\r\n");
                btnAttack.Enabled = false;
                lstHeroes.ClearSelected();
                return true;
            }

            if (allEnemiesDefeated)
            {
                txtResult.AppendText("敵は全滅した！\r\n");
                btnAttack.Enabled = false;
                lstEnemies.ClearSelected();
                return true;
            }

            return false;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeBattle();
        }
    }
}
